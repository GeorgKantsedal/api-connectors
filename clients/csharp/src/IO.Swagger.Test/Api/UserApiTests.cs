/* 
 * BitMEX API
 *
 * REST API for the BitMEX.com trading platform.<br><br><a href=\"/app/restAPI\">REST Documentation</a><br><a href=\"/app/wsAPI\">Websocket Documentation</a>
 *
 * OpenAPI spec version: 1.2.0
 * Contact: support@bitmex.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing UserApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class UserApiTests
    {
        private UserApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UserApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UserApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' UserApi
            Assert.IsInstanceOfType(typeof(UserApi), instance, "instance is a UserApi");
        }

        
        /// <summary>
        /// Test UserCancelWithdrawal
        /// </summary>
        [Test]
        public void UserCancelWithdrawalTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string token = null;
            //var response = instance.UserCancelWithdrawal(token);
            //Assert.IsInstanceOf<Transaction> (response, "response is Transaction");
        }
        
        /// <summary>
        /// Test UserCheckReferralCode
        /// </summary>
        [Test]
        public void UserCheckReferralCodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string referralCode = null;
            //var response = instance.UserCheckReferralCode(referralCode);
            //Assert.IsInstanceOf<double?> (response, "response is double?");
        }
        
        /// <summary>
        /// Test UserConfirmEmail
        /// </summary>
        [Test]
        public void UserConfirmEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string token = null;
            //var response = instance.UserConfirmEmail(token);
            //Assert.IsInstanceOf<AccessToken> (response, "response is AccessToken");
        }
        
        /// <summary>
        /// Test UserConfirmEnableTFA
        /// </summary>
        [Test]
        public void UserConfirmEnableTFATest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string token = null;
            //string type = null;
            //var response = instance.UserConfirmEnableTFA(token, type);
            //Assert.IsInstanceOf<bool?> (response, "response is bool?");
        }
        
        /// <summary>
        /// Test UserConfirmPasswordReset
        /// </summary>
        [Test]
        public void UserConfirmPasswordResetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string token = null;
            //string newPassword = null;
            //var response = instance.UserConfirmPasswordReset(token, newPassword);
            //Assert.IsInstanceOf<bool?> (response, "response is bool?");
        }
        
        /// <summary>
        /// Test UserConfirmWithdrawal
        /// </summary>
        [Test]
        public void UserConfirmWithdrawalTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string token = null;
            //var response = instance.UserConfirmWithdrawal(token);
            //Assert.IsInstanceOf<Transaction> (response, "response is Transaction");
        }
        
        /// <summary>
        /// Test UserDisableTFA
        /// </summary>
        [Test]
        public void UserDisableTFATest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string token = null;
            //string type = null;
            //var response = instance.UserDisableTFA(token, type);
            //Assert.IsInstanceOf<bool?> (response, "response is bool?");
        }
        
        /// <summary>
        /// Test UserGet
        /// </summary>
        [Test]
        public void UserGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.UserGet();
            //Assert.IsInstanceOf<User> (response, "response is User");
        }
        
        /// <summary>
        /// Test UserGetAffiliateStatus
        /// </summary>
        [Test]
        public void UserGetAffiliateStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.UserGetAffiliateStatus();
            //Assert.IsInstanceOf<List<Affiliate>> (response, "response is List<Affiliate>");
        }
        
        /// <summary>
        /// Test UserGetCommission
        /// </summary>
        [Test]
        public void UserGetCommissionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.UserGetCommission();
            //Assert.IsInstanceOf<List<UserCommission>> (response, "response is List<UserCommission>");
        }
        
        /// <summary>
        /// Test UserGetDepositAddress
        /// </summary>
        [Test]
        public void UserGetDepositAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string currency = null;
            //var response = instance.UserGetDepositAddress(currency);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test UserGetMargin
        /// </summary>
        [Test]
        public void UserGetMarginTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string currency = null;
            //var response = instance.UserGetMargin(currency);
            //Assert.IsInstanceOf<Margin> (response, "response is Margin");
        }
        
        /// <summary>
        /// Test UserGetWalletHistory
        /// </summary>
        [Test]
        public void UserGetWalletHistoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string currency = null;
            //var response = instance.UserGetWalletHistory(currency);
            //Assert.IsInstanceOf<List<Transaction>> (response, "response is List<Transaction>");
        }
        
        /// <summary>
        /// Test UserLogin
        /// </summary>
        [Test]
        public void UserLoginTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string email = null;
            //string password = null;
            //string token = null;
            //var response = instance.UserLogin(email, password, token);
            //Assert.IsInstanceOf<AccessToken> (response, "response is AccessToken");
        }
        
        /// <summary>
        /// Test UserLogout
        /// </summary>
        [Test]
        public void UserLogoutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.UserLogout();
            
        }
        
        /// <summary>
        /// Test UserLogoutAll
        /// </summary>
        [Test]
        public void UserLogoutAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.UserLogoutAll();
            //Assert.IsInstanceOf<double?> (response, "response is double?");
        }
        
        /// <summary>
        /// Test UserNew
        /// </summary>
        [Test]
        public void UserNewTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string email = null;
            //string password = null;
            //string country = null;
            //string username = null;
            //string firstname = null;
            //string lastname = null;
            //string acceptsTOS = null;
            //string referrerID = null;
            //string tfaType = null;
            //string tfaToken = null;
            //var response = instance.UserNew(email, password, country, username, firstname, lastname, acceptsTOS, referrerID, tfaType, tfaToken);
            //Assert.IsInstanceOf<User> (response, "response is User");
        }
        
        /// <summary>
        /// Test UserRequestEnableTFA
        /// </summary>
        [Test]
        public void UserRequestEnableTFATest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string type = null;
            //var response = instance.UserRequestEnableTFA(type);
            //Assert.IsInstanceOf<bool?> (response, "response is bool?");
        }
        
        /// <summary>
        /// Test UserRequestPasswordReset
        /// </summary>
        [Test]
        public void UserRequestPasswordResetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string email = null;
            //var response = instance.UserRequestPasswordReset(email);
            //Assert.IsInstanceOf<bool?> (response, "response is bool?");
        }
        
        /// <summary>
        /// Test UserRequestWithdrawal
        /// </summary>
        [Test]
        public void UserRequestWithdrawalTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string currency = null;
            //decimal? amount = null;
            //string address = null;
            //string otpToken = null;
            //double? fee = null;
            //var response = instance.UserRequestWithdrawal(currency, amount, address, otpToken, fee);
            //Assert.IsInstanceOf<Transaction> (response, "response is Transaction");
        }
        
        /// <summary>
        /// Test UserSavePreferences
        /// </summary>
        [Test]
        public void UserSavePreferencesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string prefs = null;
            //bool? overwrite = null;
            //var response = instance.UserSavePreferences(prefs, overwrite);
            //Assert.IsInstanceOf<User> (response, "response is User");
        }
        
        /// <summary>
        /// Test UserSendVerificationEmail
        /// </summary>
        [Test]
        public void UserSendVerificationEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string email = null;
            //var response = instance.UserSendVerificationEmail(email);
            //Assert.IsInstanceOf<bool?> (response, "response is bool?");
        }
        
        /// <summary>
        /// Test UserUpdate
        /// </summary>
        [Test]
        public void UserUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string firstname = null;
            //string lastname = null;
            //string oldPassword = null;
            //string newPassword = null;
            //string newPasswordConfirm = null;
            //string username = null;
            //string country = null;
            //string pgpPubKey = null;
            //var response = instance.UserUpdate(firstname, lastname, oldPassword, newPassword, newPasswordConfirm, username, country, pgpPubKey);
            //Assert.IsInstanceOf<User> (response, "response is User");
        }
        
    }

}