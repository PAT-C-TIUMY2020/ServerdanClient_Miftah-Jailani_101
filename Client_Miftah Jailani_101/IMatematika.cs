﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceMtk_P1_101
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IMatematika
    {
        [OperationContract]
        /* output->*/
        int Tambah(int a, int b); //method
        [OperationContract]
        int Kurang(int a, int b); //input
        [OperationContract]
        int Kali(int a, int b);
        [OperationContract]
        int Bagi(int a, int b);
        [OperationContract]
    }

}
