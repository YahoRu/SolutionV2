using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Test6
{
    public class ClientBase<T> : ISaveAndReadable<T>, ICRUDable<T> where T: Client
    {
        private List<T> ClientBaseList = new List<T>();

        public void Save()
        {
            string json = null;

            foreach (var item in ClientBaseList)
            {
                json += JsonSerializer.Serialize(item) + "\n";
            }

            using (var stream = new FileStream("ClientBase.json", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            {
                using (StreamWriter sw = new StreamWriter(stream))
                {
                    sw.WriteLine(json);
                }
            }
        }

        public void Read()
        {
            string json = null;

            using (var stream  = new FileStream("ClientBase.json", FileMode.Open, FileAccess.Read, FileShare.None))
            {
                using(StreamReader sr = new StreamReader(stream))
                {
                    var temp = sr.ReadToEnd();
                    Console.WriteLine(temp);
                }
            }

        }

        public void Create(T obj)
        {
            int clientId = 0;
            ClientBaseList.Add(obj);
            clientId = ClientBaseList.Count;
            obj.ChangeId(clientId);
        }

        public T Read(string name)
        {
            foreach (var item in ClientBaseList)
            {
                if(item.Name == name)
                {
                    return item;
                }
            }
            return null;
        }

        public void Update(string name)
        {
            foreach (var item in ClientBaseList)
            {
                if (item.Name == name)
                {
                    item.ChangeRights();
                }
            }
        }

        public void Delete(string name)
        {
            string temp = null;
            int index = 0;
            foreach (var item in ClientBaseList)
            {
                if (item.Name == name)
                {
                    temp = name;
                    index = ClientBaseList.IndexOf(item);
                }
            }

            if(temp != null)
            {
                ClientBaseList.RemoveAt(index);
            }
        }

    }
}
