﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesignPattern.Command.Interface
{
    public interface IElectronicDevice
    {
        void On();
        void Off();
        void VolumeUp();    
        void VolumeDown();  
    }
}
