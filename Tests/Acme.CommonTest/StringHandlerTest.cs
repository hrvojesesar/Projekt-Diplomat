﻿using Acme.common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {

            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";
     


            var actual = source.InsertSpaces();

            Assert.AreEqual(expected, actual);






        }

        [TestMethod]
        public void InsertSpacesWithExistingSpace()
        {

            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";
           


            var actual = source.InsertSpaces();

            Assert.AreEqual(expected, actual);






        }



    }
}
