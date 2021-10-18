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
            byte  Stage, Mode, Error, Warning, Blinking;
            int   RunningTime, ModeTime;
            byte  HeaterMode, WarmupMode;
            int   TimeToWorkM;
            int   TairSetpoint;
            byte  PumpOnWaitingMode, PumpOnEngineStarted;
            byte  EngineStarted, SignalingLatched;
            float Usupply, Uengine;
            int   Pressure, FanDef, FanMsr;
            float FPDef, FPRlz;
            int   GP, Pump, Relay, Tflame, Tframe, Trod, Tplate, Tliq, Tovh, Tair, Tinlet, Tpanel;
            int   FlameMin, FlameCool, FlameLimit, FlameDT;
            float PMax, PMin, dP, PressurePGN29;
        };

        List<TDevice> Device = new List<TDevice>();

        public Parameters()
        {
            protocolCAN.ReadCAN += CANMsg;
        }

        private void CANMsg(ProtocolCAN.TMessage AMessage)
        {
        }
    }
}
