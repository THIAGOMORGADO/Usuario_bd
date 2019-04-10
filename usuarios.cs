using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Usuarios
{
    #region Usuarios
    public class Usuarios
    {
        #region Member Variables
        protected int _id;
        protected string _email;
        protected string _senha;
        protected string _nome;
        #endregion
        #region Constructors
        public Usuarios() { }
        public Usuarios(string email, string senha, string nome)
        {
            this._email=email;
            this._senha=senha;
            this._nome=nome;
        }
        #endregion
        #region Public Properties
        public virtual int Id
        {
            get {return _id;}
            set {_id=value;}
        }
        public virtual string Email
        {
            get {return _email;}
            set {_email=value;}
        }
        public virtual string Senha
        {
            get {return _senha;}
            set {_senha=value;}
        }
        public virtual string Nome
        {
            get {return _nome;}
            set {_nome=value;}
        }
        #endregion
    }
    #endregion
}