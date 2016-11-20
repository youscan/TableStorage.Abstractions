﻿using System.Collections.Generic;

namespace TableStorage.Abstractions.Tests.Helpers
{
    internal static class TestDataHelper
    {
        #region Helpers
       
        public static void SetupRecords(ITableStore<TestTableEntity> tableStorage)
        {
            var entityList = new List<TestTableEntity>
            {
                new TestTableEntity("John", "Smith") {Age = 21, Email = "john.smith@something.com"},
                new TestTableEntity("Jane", "Smith") {Age = 28, Email = "jane.smith@something.com"}
            };

            tableStorage.Insert(entityList);

            var anotherEntityList = new List<TestTableEntity>
            {
                new TestTableEntity("Fred", "Jones") {Age = 32, Email = "fred.jones@somewhere.com"},
                new TestTableEntity("Bill", "Jones") {Age = 45, Email = "bill.jones@somewhere.com"}
            };

            tableStorage.Insert(anotherEntityList);
        }

        public static void SetupRowKeyRecords(ITableStore<TestTableEntity> tableStorage)
        {
            var entityList = new List<TestTableEntity>
            {
                new TestTableEntity("John", "Smith") {Age = 21, Email = "john.smith@something.com"},
                new TestTableEntity("Jane", "Smith") {Age = 28, Email = "jane.smith@something.com"},
                new TestTableEntity("Bill", "Smith") { Age = 38, Email = "bill.smith@another.com"}
            };

            tableStorage.Insert(entityList);

            var anotherEntityList = new List<TestTableEntity>
            {
                new TestTableEntity("Fred", "Jones") {Age = 32, Email = "fred.jones@somewhere.com"},
                new TestTableEntity("Bill", "Jones") {Age = 45, Email = "bill.jones@somewhere.com"}
            };

            tableStorage.Insert(anotherEntityList);

            var moreEntityList = new List<TestTableEntity>
            {
                new TestTableEntity("Bill", "King") {Age = 45, Email = "bill.king@email.com"}
            };

            tableStorage.Insert(moreEntityList);

            var evenMoreEntityList = new List<TestTableEntity>
            {
                new TestTableEntity("Fred", "Bloggs") { Age = 32, Email = "fred.bloggs@email.com" }
            };

            tableStorage.Insert(evenMoreEntityList);
        }

        public static List<TestTableEntity> GetMultiplePartitionKeyRecords()
        {
            return new List<TestTableEntity>
            {
                new TestTableEntity("John", "Smith") {Age = 21, Email = "john.smith@something.com"},
                new TestTableEntity("Jane", "Smith") {Age = 28, Email = "jane.smith@something.com"},
                new TestTableEntity("Bill", "Smith") { Age = 38, Email = "bill.smith@another.com"},
                new TestTableEntity("Fred", "Jones") {Age = 32, Email = "fred.jones@somewhere.com"},
                new TestTableEntity("Bill", "Jones") {Age = 45, Email = "bill.jones@somewhere.com"},
                new TestTableEntity("Bill", "King") {Age = 45, Email = "bill.king@email.com"},
                new TestTableEntity("Fred", "Bloggs") { Age = 32, Email = "fred.bloggs@email.com" }
            };            
        }

        #endregion Helpers
    }
}