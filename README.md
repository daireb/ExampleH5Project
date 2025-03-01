# ExampleH5Project

## Overview

This is an example project showing how [H5](https://github.com/curiosity-ai/h5) can be used to write modules for Node/TS rather than just building `index.html` and web-apps. It demonstrates how to share logic between C# and TypeScript projects.

It may seem simple, but as someone who is new to this and was struggling for the last day on this, I hope this repo helps someone in future! 

**TL;DR: You can just ignore `index.html` and require the .js files directly, pretty much!**

## Getting Started

### Prerequisites
- Node.js
- TypeScript
- H5
- .NET SDK

### Installation
1. Clone the repository:
    ```sh
    git clone https://github.com/daireb/ExampleH5Project.git
    cd ExampleH5Project
    ```

2. Install the dependencies:
    ```sh
    npm install
    ```

### Building the Project from C#
To compile from C# to JS/TS, run the following command:
    ```
    dotnet build
    ```

### Running the Project
To run the project, execute the TypeScript or JavaScript files as normal:
    ```
    node src/test.js
    ```
    or
    ```
    npx ts-node src/test.ts
    ```


### Usage
The main logic is in `SharedLogic.cs`, which compiles into the `/dist` folder. The logic can then be accessed as shown in `test.js` and `test.ts`.

It's important to require the `h5.js` file before the shared logic, as it sets up the H5 environment.

#### Example Javascript Import
```javascript
require(`../dist/h5.js`);
require(`../dist/MySharedLogic.js`);

// Rest of your script
```

#### Example Typescript Import
```typescript
/// <reference path="../dist/MySharedLogic.d.ts" />

require(`../dist/h5.js`);
require(`../dist/MySharedLogic.js`);

// Rest of your script
```
