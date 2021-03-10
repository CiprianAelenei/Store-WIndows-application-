using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPAW.Services
{
    public interface IClientService
    {
        /// <summary>
        /// Returns all clients
        /// </summary>
        /// <returns>List of Client objects</returns>
        List<Client> GetAllClients();

        /// <summary>
        /// Save a client to db
        /// </summary>
        /// <param name="newC"></param>
        void SaveClient(Client newC);
    }

    public class ClientService : IClientService
    {
        private readonly string connectionString =
            @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\cipri\Desktop\ProjectPAW\ProjectPAW\Database\Database1.accdb";
        private readonly OleDbConnection _Connection;
        public ClientService()
        {
            _Connection = new OleDbConnection(connectionString);
        }


        public List<Client> GetAllClients()
        {
            List<Client> clients = new List<Client>();
            OleDbCommand cmd = _Connection.CreateCommand();
            _Connection.Open();
            cmd.CommandText = "SELECT id, nume, adresa_email, telefon, card_fidelitate FROM clients";
            cmd.Connection = _Connection;
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                clients.Add(new Client(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                    reader.GetBoolean(4), null));
            }

            reader.Close();
            _Connection.Close();
            return clients;
        }

        public void SaveClient(Client newC)
        {
            string insertCommandFormat = "INSERT INTO clients(nume, adresa_email, telefon, card_fidelitate) VALUES('{0}', '{1}', '{2}', {3})";
            OleDbCommand cmd = _Connection.CreateCommand();
            _Connection.Open();
            cmd.CommandText = string.Format(insertCommandFormat, newC.Nume, newC.AdresaEmail, newC.NrTel, newC.CardFidel);
            cmd.Connection = _Connection;
            var rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected != 1)
            {
                throw new Exception("Insert client failed");
            }
            _Connection.Close();
        }
    }
}
