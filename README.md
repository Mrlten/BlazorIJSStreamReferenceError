# Blazor IJSStreamReference error

It isn't possible to use a `IJSStreamReference` again after the browser's Blazor session has reconnected.
It throws the `Uncaught (in promise) Error: Cannot send data if the connection is not in the 'Connected' State.` in the browser's console and after 30 seconds a
`System.TimeoutException: Did not receive any data in the allotted time.` at the server.