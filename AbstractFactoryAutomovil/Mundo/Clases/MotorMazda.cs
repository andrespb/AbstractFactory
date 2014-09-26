using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryAutomovil.Mundo.Interfaces;

namespace AbstractFactoryAutomovil.Mundo.Clases
{
    class MotorMazda: IMotor
    {
        public String darNombre()
        {
            return " Motor Mazda";
        }
    }
}
