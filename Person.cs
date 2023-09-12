using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister
{
    internal class Person
    {
        private string forNamn;
        private string efterNamn;
        private int alder;

        public Person(string forNamn, string efterNamn)
        {
            this.setForNamn(forNamn);
            this.setEfterNamn(efterNamn);
        }
        public Person(string forNamn, string efterNamn, int alder )
        {
            this.setForNamn(forNamn);
            this.setEfterNamn(efterNamn);
            this.setAlder(alder);
        }

        public int getAlder() {  return this.alder; }
        public string getEfterNamn() {  return this.efterNamn; }
        public string getForNamn() { return this.forNamn; }
        public string getFullName() {  return this.forNamn + " " + this.efterNamn; }

        public void setAlder(int alder) {  this.alder = alder; }
        public void setForNamn(string forNamn) {  this.forNamn = forNamn;}
        public void setEfterNamn(string EfterNamn) { this.efterNamn= EfterNamn;}
        public void okaAlder() {  this.alder += 1; }

    }
}
