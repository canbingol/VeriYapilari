using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilari
{
    internal class Liste
    {
      public   Node head;
        public void liste()
        {

            if (head == null)
            {
                Console.WriteLine(" Liste Boş");
            }

        }
        public void SonaEkle(int data)
        {
            Node eleman = new Node(data);

            if (head == null)
            {
                head = eleman;
                Console.WriteLine(" İlk Düğüm Eklendi ");
            }
            else
            {
                Node temp = head;

                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = eleman;
                Console.WriteLine("Sona Düğüm Eklendi ");

            }


        }
        public void BasaEkle(int data)
        {
            Node temp = new Node(data);
            if (head == null)
            {
                head = temp;
                Console.WriteLine("Liste Oluşturuldu, İlk Değer Eklendi");
            }else
            {
                temp.next = head;
                head = temp;
                Console.WriteLine(" Başa Ekleme Yapıldı");
            }


        }
        public void Yazdır()
        {
            Node temp = head;
            if (head == null)
            {
                Console.WriteLine(" Liste Boş");
            }
            else
            {

                Console.Write(" Baş --> ");
                while (temp.next != null)
                {
                    Console.Write(temp.data + "-->");
                    temp = temp.next;
                }
                Console.WriteLine(temp.data + " Son");
            }
        }
        

    }
}
