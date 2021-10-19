using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeMan
{
    class Parameters
    {
        ProtocolCAN protocolCAN = new ProtocolCAN();

        struct TDevice
        {
            public byte DevType, DevAddr;                           //тип и адрес устройства

            public byte Stage, Mode, Error, Warning, Blinking;
            public int RunningTime, ModeTime;
            public byte HeaterMode, WarmupMode;
            public int TimeToWorkM;
            public int TairSetpoint;
            public byte PumpOnWaitingMode, PumpOnEngineStarted;
            public byte EngineStarted, SignalingLatched;
            public float Usupply, Uengine;
            public int Pressure, FanDef, FanMsr;
            public float FPDef, FPRlz;
            public int GP, Pump, Relay, Tflame, Tframe, Trod, Tplate, Tliq, Tovh, Tair, Tinlet, Tpanel;
            public int FlameMin, FlameCool, FlameLimit, FlameDT;
            public float PMax, PMin, dP, PressurePGN29;
        };

        const byte DeviceCount = 20;                                           //максимальное количество устройств в сети
        byte DevicePointer = 255;
        TDevice[] Device = new TDevice[DeviceCount];

        public Parameters()
        {
            protocolCAN.ReadCAN += CANMessageProcess;
        }

        private void CANMessageProcess(ProtocolCAN.TMessage AMsg)
        {
            int N = -1;

            for (int i = 0; i < DeviceCount-1; i++)                            //поиск уже добавленного устройства в списке
                if (AMsg.TransmitterType == Device[i].DevType &&
                    AMsg.TransmitterAddr == Device[i].DevAddr)
                {
                    N = i;
                    break;
                }
            if (N == -1)                                                       //устройства в списке нет. добавляем
            {
                if (DevicePointer < DeviceCount - 1)                           //еще есть место в массиве
                {
                    DevicePointer++;
                    N = DevicePointer;
                }
                else                                                           //места в массиве нет. не обрабатываем сообщение
                {
                    return;
                }
            }
            switch (AMsg.PGN)
            {
                case 10:
                    Device[N].Stage = AMsg.Data[0];
                    Device[N].Mode = AMsg.Data[1];
                    Device[N].Error = AMsg.Data[2];
                    Device[N].Warning = AMsg.Data[4];
                    Device[N].Blinking = AMsg.Data[5];
                    break;

            }
        }
    }
}
