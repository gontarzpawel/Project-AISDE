﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolejka
{
    public interface IKolejkaable<D>
    {
        //metods
        void insert(D objekt);
        void delete(D objekt);
        int count();
        
    }
}
