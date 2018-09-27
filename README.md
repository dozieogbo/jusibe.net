# Jusibe.NET

.NET Client Library for Jusibe SMS REST API Service https://jusibe.com

## Installation

To get the latest version of Jusibe.NET, on your Package Manager Console, run.

```sh
Install-Package Jusibe.NET -Version 1.0.0
```
## Usage
To use the API, you require a public key and access token. These can be gotten from https://dashboard.jusibe.com/api-keys

To initialize, use:

```cs
  string publicKey = "--INSERT YOUR PUBLIC KEY--";
  string accessToken = "--INSERT YOUR ACCESS TOKEN--";

  Jusibe jusibe = new Jusibe(publicKey, accessToken);
```

Available methods for use are:
```cs
//Send a message to one number
SendSMS(string from, string to, string message)

//Send message to multiple numbers
SendBulkSMS(string from, List<string> to, string message)

//Check status of bulk SMS message
CheckBulkSMSStatus(string bulkMessageId)

//Check status of SMS
CheckSMSStatus(string messageId)

//Check available credits
CheckAvaliableCredits()
```

**NB:** All methods are asynchronous and.

Examples of usage can be found [here](https://github.com/dozieogbo/jusibe.net/blob/master/JusibeNET.Example/Program.cs)

## How can I thank you?

Why not star the github repo? I'd love the attention! Why not share the link for this repository on Twitter or HackerNews? Spread the word!

Don't forget to [follow me on twitter](https://twitter.com/dozieogbo)!

Thanks!
Chidozie Ogbo.

## License

The MIT License (MIT). Please see [License File](LICENSE.md) for more information.
