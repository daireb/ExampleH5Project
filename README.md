# ExampleH5Project

## Overview

This is an example project showing how H5 can be used to write modules in JS/TS rather than just websites. It demonstrates how to share logic between C# and TypeScript projects.

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

```typescript
/// <reference path="../dist/MySharedLogic.d.ts" />

require(`../dist/h5.js`);
require(`../dist/MySharedLogic.js`);
```