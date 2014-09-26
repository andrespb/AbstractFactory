using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryAutomovil.Mundo.Interfaces;
using AbstractFactoryAutomovil.Mundo.Clases;

namespace AbstractFactoryAutomovil.Mundo.Fabricas
{
    class FabricaRenault: IFabricaDePartes
    {

        public IAuto crearAuto()
        {
            return new AutoRenault();
        }

        public IMotor crearMotor()
        {
            return new MotorRenault();
        }

        public ICarroceria crearCarroceria()
        {
            return new CarroceriaRenault();
        }
    }
}
