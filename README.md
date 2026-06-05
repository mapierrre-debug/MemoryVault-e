# Privacy-First Personal Memory Vault

## Overview
A web application operating entirely within the browser via IndexedDB and WebAssembly. It offers a seamless, high-speed interface that remains fully functional offline. Sensitive personal journals and encrypted passwords never touch an external server.

## Architecture
- **Front-End:** Blazor WebAssembly (WASM).
- **Styling:** Custom CSS with neon/dark-mode aesthetics and CSS animations.
- **Data Persistence:** Native JavaScript IndexedDB wrapped with JSInterop.
- **Host:** ASP.NET Core (Acting purely as a static asset server).

## Running the Project
1. Navigate to the Server directory.
2. Run dotnet run.
3. Open the supplied localhost port in your browser.
