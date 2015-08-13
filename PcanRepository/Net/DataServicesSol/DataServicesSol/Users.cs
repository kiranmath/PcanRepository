using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServicesSol
{
    class Users
    {



        int _UserID;
        public int UserID
        {

            get { return this._UserID; }
            set { this._UserID = value; }
        }

        string _EmailAddress;
        public string EmailAddress
        {

            get { return this._EmailAddress; }
            set { this._EmailAddress = value; }
        }


        string _FirstName;
        public string FirstName
        {

            get { return this._FirstName; }
            set { this._FirstName = value; }
        }

        string _LastName;
        public string LastName
        {

            get { return this._LastName; }
            set { this._LastName = value; }
        }

        string _UserName;
        public string UserName
        {

            get { return this._UserName; }
            set { this._UserName = value; }
        }

        string _UserTypeCode;
        public string UserTypeCode
        {

            get { return this._UserTypeCode; }
            set { this._UserTypeCode = value; }
        }

        string _UserTypeID;
        public string UserTypeID
        {

            get { return this._UserTypeID; }
            set { this._UserTypeID = value; }
        }

        string _UserTypeDescription;
        public string UserTypeDescription
        {

            get { return this._UserTypeDescription; }
            set { this._UserTypeDescription = value; }
        }
    }
}
