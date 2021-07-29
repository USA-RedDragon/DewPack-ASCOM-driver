using ASCOM.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using Google.Protobuf;

using Consistent_Overhead_Byte_Stuffing;
using ASCOM.DewPack.Proto;

namespace ASCOM.DewPack
{
    public class PacketSerial
    {
        private Serial serial;
        public string PortName
        {
            get => serial.PortName;
            set
            {
                serial.PortName = value;
            }
        }

        public SerialSpeed Speed
        {
            get => serial.Speed;
            set
            {
                serial.Speed = value;
            }
        }

        public DeviceState CurrentState { get; internal set; }
        private bool _Connected;
        public bool Connected {
            get => _Connected;
            set
            {
                serial.Connected = value;
                if (value)
                {
                    ReadProtoMessage();
                    if (value != _Connected)
                    {
                        Thread t = new Thread(new ThreadStart(ListenThread));
                        t.IsBackground = true;
                        t.Start();
                    }
                    _Connected = true;
                } else
                {
                    _Connected = false;
                }
            }
        }

        public PacketSerial()
        {
            serial = new Serial();
        }

        internal void ReadProtoMessage()
        {
            List<byte> data = new List<byte>();
            try
            {
                byte serialByte = serial.ReceiveByte();
                while (serialByte != '\x00')
                {
                    data.Add(serialByte);
                    serialByte = serial.ReceiveByte();
                }
            }
            catch (System.IO.IOException ex) { }

            List<byte> protoMessage = (List<byte>)COBS.Decode(data);
            CurrentState = DeviceState.Parser.ParseFrom(protoMessage.ToArray());
        }

        public void WriteDeviceState(DeviceState deviceState)
        {
            List<byte> encodedProto = (List<byte>)COBS.Encode(deviceState.ToByteArray());
            encodedProto.Add((byte)'\x00');
            serial.TransmitBinary(encodedProto.ToArray());
        }

        internal void ListenThread()
        {
            while (Connected && serial.Connected)
            {
                ReadProtoMessage();
            }
        }
    }
}
