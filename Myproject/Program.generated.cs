//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Myproject {
    using Gadgeteer;
    using GTM = Gadgeteer.Modules;
    
    
    public partial class Program : Gadgeteer.Program {
        
        /// <summary>The USB Client EDP module using socket 1 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.USBClientEDP usbClientEDP;
        
        /// <summary>The Display T35 module using sockets 14, 13, 12 and 10 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.DisplayT35 displayT35;
        
        /// <summary>The SD Card module using socket 5 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.SDCard sdCard;
        
        /// <summary>The Breakout module using socket 4 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.Breakout breakout;
        
        /// <summary>The Breakout module using socket 9 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.Breakout breakout2;
        
        /// <summary>The Button module using socket 6 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.Button button;
        
        /// <summary>The Button module using socket 11 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.Button button2;
        
        /// <summary>The Ethernet J11D module using socket 7 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.EthernetJ11D ethernetJ11D;
        
        /// <summary>This property provides access to the Mainboard API. This is normally not necessary for an end user program.</summary>
        protected new static GHIElectronics.Gadgeteer.FEZSpiderII Mainboard {
            get {
                return ((GHIElectronics.Gadgeteer.FEZSpiderII)(Gadgeteer.Program.Mainboard));
            }
            set {
                Gadgeteer.Program.Mainboard = value;
            }
        }
        
        /// <summary>This method runs automatically when the device is powered, and calls ProgramStarted.</summary>
        public static void Main() {
            // Important to initialize the Mainboard first
            Program.Mainboard = new GHIElectronics.Gadgeteer.FEZSpiderII();
            Program p = new Program();
            p.InitializeModules();
            p.ProgramStarted();
            // Starts Dispatcher
            p.Run();
        }
        
        private void InitializeModules() {
            this.usbClientEDP = new GTM.GHIElectronics.USBClientEDP(1);
            this.displayT35 = new GTM.GHIElectronics.DisplayT35(14, 13, 12, 10);
            this.sdCard = new GTM.GHIElectronics.SDCard(5);
            this.breakout = new GTM.GHIElectronics.Breakout(4);
            this.breakout2 = new GTM.GHIElectronics.Breakout(9);
            this.button = new GTM.GHIElectronics.Button(6);
            this.button2 = new GTM.GHIElectronics.Button(11);
            this.ethernetJ11D = new GTM.GHIElectronics.EthernetJ11D(7);
        }
    }
}
