// Ensure you import h5.js before SharedLogic.js
require(`../dist/h5.js`);
require('../dist/SharedLogic.js'); // any static functions labelled "Main" will run on require

// Running static methods directly from the namespace
SharedLogic.TestProgram.PrintTest();

// Classes can be created and used too!
Player = new SharedLogic.Player(10, 20);
Player.PrintPosition();