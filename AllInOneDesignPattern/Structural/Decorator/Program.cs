// See https://aka.ms/new-console-template for more information
using Decorator;
using System.IO.Compression;
using System.Net.Sockets;
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");

FileStream fileStream = null;
MemoryStream stream = null;
NetworkStream networkStream = null;

//GZipStream gZipStream = new GZipStream(fileStream, CompressionMode.Compress);
//CryptoStream cryptoStream = new CryptoStream(stream, null, CryptoStreamMode.Write);


Mail mail = new Mail();
SignedMail signedMail = new SignedMail(mail);
signedMail.SignAndSend();
CryptedMail cryptedMail = new CryptedMail(signedMail);
cryptedMail.CryptedSend();

ArchivedMail archivedMail = new ArchivedMail(cryptedMail);
archivedMail.Archive();


