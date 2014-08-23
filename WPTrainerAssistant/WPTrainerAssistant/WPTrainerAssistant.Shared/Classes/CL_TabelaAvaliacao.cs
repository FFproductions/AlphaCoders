using System;
using System.Collections.Generic;
using System.Text;

namespace WPTrainerAssistant
{
    class CL_TabelaAvaliacao
    {
        #region Attributes
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _comments;

        public string Comments
        {
            get { return _comments; }
            set { _comments = value; }
        }

        #endregion

        #region Construtor(s)

        public CL_TabelaAvaliacao()
        {
            _id = 0;
            _name = "";
            _comments = "";
        }

        public CL_TabelaAvaliacao (int id, string name, string comments)
        {
            _id = id;
            _name = name;
            _comments = comments;
        }

        #endregion

        public static List<CL_TabelaAvaliacao> ListaTabelasAvalicao()
        {
            List<CL_TabelaAvaliacao> rList = new List<CL_TabelaAvaliacao>();
            //TODO - implement logic
            return rList;
        }


    }
}
