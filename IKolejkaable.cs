﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Kolejka
{
    public interface IKolejkaable<D,K> where K: IComparable
    {
        //metody
        void dodaj(D objekt, K klucz);
        Element<D,K> usun();
        int zwrocRozmiar();
        D dane(int i);
        K klucz(int i);
        //K klucz(int i);
    }
}
