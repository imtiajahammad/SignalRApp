# SignalRApp
A web app implementing SignalR


Reference: https://www.youtube.com/watch?v=RaXx_f3bIRU&ab_channel=IAmTimCorey

#1
adding nuget package: Microsoft.AspNetCore.SignalR.Client

#2
New folder called Hubs;
New class named ChatHub.cs; inherits from Hub; add method for signalR
#3
Setup Program File for SignalR:
    add using for ResponseCompression
    add using for Hubs
    add ResponseCompression to use builder.Services
    add map url for chatHub

#4
Client setup to consume messages
    add using SignalR.Client
    add inject NagigationManager
    add implements IAsyncDisposable for disposing
    set up code for hub connection
    set up UI for hub collaboration
