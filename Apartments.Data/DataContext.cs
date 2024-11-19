using Apartments.Entitise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartments.Data
{
    internal class DataContext
    {
        public List<apartment> apartment { get; set; }
        public List<Broker> Broker { get; set; }

        public List<patient> patient { get; set; }

        public DataContext()
        {

            apartment = new List<apartment>

        {
            new apartment{City="bnei brak",ApartmentNum=126,NumRooms=3,Size=120,Floor=1,Type="for sale",Amount=250000000},
            new apartment{City="Jerusalem",ApartmentNum=421,NumRooms=5,Size=110,Floor=2,Type="for rent",Amount=350000000},
            new apartment{City="modien elit",ApartmentNum=236,NumRooms=2,Size=90,Floor=5,Type="for sale",Amount=25000000},
            new apartment{City="ramat gan",ApartmentNum=154,NumRooms=4,Size=105,Floor=6,Type="for rent",Amount=27000000},

        };

            Broker = new List<Broker>

        {
            new Broker{Name="nati levi",Id=625412368,Phone_number=0523698541,Email="rfcvb@gmail.com",Adress="rabi akiva 64"},
            new Broker{Name="kobi choen",Id=625412371,Phone_number=0523698543,Email="cghjcc@gmail.com",Adress="hashomer 135"},
            new Broker{Name="dani kaz",Id=128888773,Phone_number=0523698545,Email="nlho@gmail.com",Adress="chazon eish 26"},
            new Broker{Name="yron shapira",Id=854123652,Phone_number=0523698548,Email="nlho@gmail.com",Adress="hevron 35"}
        };

            patient = new List<patient> {
            new patient{Name="ruti sasson",Id=123456789,Phone_number=058423166,Email=",mnbv@gmail.com",Adress="bagno 15,bnei brak",Preferred_area=4},
            new patient{Name="naama nougershal",Id=987654321,Phone_number=054253998,Email="safza@gmail.com",Adress="miron 16,bnei brak",Preferred_area=3},
            new patient{Name="riki rozental",Id=147852369,Phone_number=052635874,Email="recac254@gmail.com",Adress="harv kok 8 bnei brak",Preferred_area=4},
            new patient{Name="ayala sasson",Id=123654478,Phone_number=058695812,Email="NULL",Adress="bagno 18,bnei brak",Preferred_area=2}

            };

        }
    }
}
