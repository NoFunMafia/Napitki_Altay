using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Napitki_Altay2.Tests
{
    public class MethodsForTesting
    {
        [DllImport("wininet.dll")]
        static extern bool InternetGetConnectedState
            (ref InternetConnectionState lpdwFlags, int dwReserved);
        [Flags]
        enum InternetConnectionState : int
        {
            INTERNET_CONNECTION_MODEM = 0x1,
            INTERNET_CONNECTION_LAN = 0x2,
            INTERNET_CONNECTION_PROXY = 0x4,
            INTERNET_RAS_INSTALLED = 0x10,
            INTERNET_CONNECTION_OFFLINE = 0x20,
            INTERNET_CONNECTION_CONFIGURED = 0x40
        }
        static object _syncObj = new object();
        public static bool PingServer(string[] serverList)
        {
            bool haveAnInternetConnection = false;
            Ping ping = new Ping();
            for (int i = 0; i < serverList.Length; i++)
            {
                PingReply pingReply = ping.Send(serverList[i]);
                haveAnInternetConnection =
                    (pingReply.Status == IPStatus.Success);
                if (haveAnInternetConnection)
                    break;
            }
            return haveAnInternetConnection;
        }
        public Boolean CheckConnection()
        {
            lock (_syncObj)
            {
                try
                {
                    InternetConnectionState flags
                        = InternetConnectionState.
                        INTERNET_CONNECTION_CONFIGURED | 0;
                    bool checkStatus
                        = InternetGetConnectedState(ref flags, 0);
                    if (checkStatus)
                        return PingServer(new string[]
                        {@"google.com", @"microsoft.com", @"ibm.com"});
                    return checkStatus;
                }
                catch
                {
                    return false;
                }
            }
        }
        public bool IsValid(string password)
        {
            Regex passwordPolicyExpression = new Regex(@"((?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#!$%]).{8,20})");
            return passwordPolicyExpression.IsMatch(password);
        }
        public bool IsValidEmail(string email)
        {
            Regex emailRegex = new Regex
                (@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$",
                RegexOptions.IgnoreCase);
            return emailRegex.IsMatch(email);
        }
    }
    [TestClass()]
    public class DataBaseWorkTests
    {
        [TestMethod()]
        public void GetWrongPass()
        {
            //Arrange
            var passwordValidator = new MethodsForTesting();
            const string password = "1qQ!11111";

            //Act
            bool isValid = passwordValidator.IsValid(password);

            //Assert
            bool assert = true;
            Assert.AreEqual(assert, isValid);
        }
        [TestMethod()]
        public void GetRightPass()
        {
            //Arrange
            var passwordValidator = new MethodsForTesting();
            const string password = "123";

            //Act
            bool isWrong = passwordValidator.IsValid(password);

            //Assert
            bool assert = false;
            Assert.AreEqual(assert, isWrong);
        }
        [TestMethod()]
        public void CheckInternetConnection()
        {
            //Arrange
            var method = new MethodsForTesting();

            //Act
            bool checkCon = method.CheckConnection();

            //Assert
            bool assert = true;
            Assert.AreEqual(assert, checkCon);
        }
        [TestMethod()]
        public void CheckInternetConnectionWithoutInternet()
        {
            //Arrange
            var method = new MethodsForTesting();

            //Act
            bool checkCon = method.CheckConnection();

            //Assert
            bool assert = false;
            Assert.AreEqual(assert, checkCon);
        }
        [TestMethod()]
        public void GetRightEmail()
        {
            //Arrange
            var method = new MethodsForTesting();
            const string email = "haha@rambler.ru";

            //Act
            bool isValid = method.IsValidEmail(email);

            //Assert
            bool assert = true;
            Assert.AreEqual(assert, isValid);
        }
    }
}