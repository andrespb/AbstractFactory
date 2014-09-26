using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryAutomovil.Mundo.Interfaces;
using AbstractFactoryAutomovil.Mundo.Clases;

namespace AbstractFactoryAutomovil.Mundo.Fabricas
{
    class FabricaChevrolet: IFabricaDePartes
    {
        public IAuto crearAuto()
        {
            return new AutoChevrolet();
        }

        public IMotor crearMotor()
        {
            return new MotorChevrolet();
        }

        public ICarroceria crearCarroceria()
        {
            return new CarroceriaChevrolet();
        }
    }
}
