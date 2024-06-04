using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Theater
{
    //idioapevesyxcymp
    public class Class
    {
        //Login Form
        public class User
        {
            public string username, email;
            public int permit;
            public User()
            {
                username = email = string.Empty;
                permit = -1;
            }
            public User(string u,string e, int p)
            {
                username = u;
                email = e;
                permit = p; //0:Modder 1:Staff
            }
        }
        public class Movie
        {
            public string name, origin, id, img;
            public string url;
            public long price;
            public List<int> arrRoom;
            public string info;
            public Movie()
            {
                name = origin = id = string.Empty;
                price = 0;
                arrRoom = new List<int>();
            }
            public Movie(string id, string name, string origin, string img, string url, long price, List<int> arrRoom)
            {
                this.id = id;
                this.name = name;
                this.origin = origin;
                this.price = price;
                this.arrRoom = arrRoom;
                this.img = img;
                this.url = url;
            }
            public string setInfo()
            {
                return string.Format("Giá vé chuẩn: {0}.000đ\r\nPhòng chiếu: {1}", price.ToString(), string.Join(", ", arrRoom));
            }
            public string getOrigin(string clientname)
            {
                string query = string.Format("SELECT Origin FROM INFO WHERE Id = {0};", this.id);
                return Client.Home.GetData(clientname, query).Replace("_"," ");
            }
            public string getURL(string clientname)
            {
                string query = string.Format("SELECT Url FROM INFO WHERE Id = {0};", this.id);
                return Client.Home.GetData(clientname, query);
            }
        }
        //Bill Form
        public class Price
        {
            Movie movie;
            public long normal, vip, sweet;
            public Price()
            {
                movie = new Movie();
                normal = vip = sweet = 0;
            }
            public Price(Movie m)
            {
                movie = m;
                normal = m.price;
                vip = m.price + 10;
                sweet = m.price * 2 + 30;
            }
        }
        //Seat Form
        public class Theater
        {
            public int normal, vip, sweet, col;
            public string name, id;
            public Theater()
            {
                normal = vip = sweet = col = 0;
                name = id = string.Empty;
            }
            public Theater(string id, string name, int nor, int vip, int sw)
            {
                this.id = id;
                normal = nor;
                this.vip = vip;
                sweet = sw;
                this.name = name;
            }
        }
        public class SeatCount
        {
            public int normal, vip, sweet;
            public List<string> Name;
            public string theater, id;
            public SeatCount()
            {
                normal = vip = sweet = 0;
                Name = new List<string>();
                theater = id = string.Empty;
            }
            public void Inc(int type)
            {
                if (type == 1) normal++;
                if (type == 2) vip++;
                if (type == 3) sweet++;
            }
            public void Dec(int type)
            {
                if (type == 1) normal--;
                if (type == 2) vip--;
                if (type == 3) sweet--;
            }
            public bool isEmpty()
            {
                return normal == 0 && vip == 0 && sweet == 0;
            }
        }
        public class SeatTag
        {
            public int type;
            public string name;
            public SeatTag(int type, string name)
            {
                this.type = type;
                this.name = name;
            }
        }
        public class BuyedSeat
        {
            public string id;
            public List<string> idseats;
            public BuyedSeat()
            {
                id = string.Empty;
                idseats = new List<string>();
            }
            public BuyedSeat(string id, List<string> id_se)
            {
                this.id = id;
                idseats = id_se;
            }

        }

    }
}
