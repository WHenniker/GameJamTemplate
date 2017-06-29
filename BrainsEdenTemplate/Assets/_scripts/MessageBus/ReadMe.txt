How to use the message bus.

Within Message.cs define what messages you want to use

Within MessageBus.cs add a message, a methord to broardcast a message to subscribers and define the messages in the message bus instance

each object that recives messages needs two components...

1. a message subscriber script that will allow you to define what messages the object listens for (appliable in the editor)
2. a message handler, this custom script inherits from MessageHandler instead of MonoBehavoir, the script must include an overide methord for HandleMessage.
	-you can use a switch statement in this message to seperate incoming messasges if needed.

	syntax//

	public override void HandleMessage(Message message)
    {
        switch (message.Type)
        {
            case MessageType.NONE:
                break;
            default:
                break;
        }
    }