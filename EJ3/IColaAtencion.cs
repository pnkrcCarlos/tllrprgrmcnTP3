﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    interface IColaAtencion
    {
        void Admitir(Paciente pPaciente);

        Paciente Atender();
    }
}
