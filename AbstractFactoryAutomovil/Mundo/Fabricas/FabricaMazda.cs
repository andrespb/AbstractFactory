using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryAutomovil.Mundo.Interfaces;
using AbstractFactoryAutomovil.Mundo.Clases;

namespace AbstractFactoryAutomovil.Mundo.Fabricas
{
    class FabricaMazda: IFabricaDePartes
    {

        public IAuto crearAuto()
        {
            return new AutoMazda();
        }

        public IMotor crearMotor()
        {
            return new MotorMazda();
        }

        public ICarroceria crearCarroceria()
        {
            return new CarroceriaMazda();
        }
    }
}
