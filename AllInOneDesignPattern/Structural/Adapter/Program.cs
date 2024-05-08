// See https://aka.ms/new-console-template for more information
using Adapter;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");

XMLSource source = new XMLSource();
JsonAdapter adapter = new JsonAdapter(source);

Console.WriteLine(adapter.GetData());
//DataAdapter dataAdapter = new SqlDataAdapter()
//DataSet dataTable = new DataSet();
//dataAdapter.Fill(dataTable);
