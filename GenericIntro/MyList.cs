﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericIntro
{
     class MyList<T>
    {
        T[] items;
        public MyList()  //constructor class newlenirse direk çalışıyor  -ctor yazarak ulaşıldı-
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items=new T[items.Length+1];
            for (int i = 0; i <tempArray.Length; i++)  //önce tutulan elemanları geri aldı.
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }

    }
}
