using UnityEngine;

//add messages you want to send here, use a dictionary if the list gets too big
public enum MessageType
{
	NONE,
	LevelStart,
	LevelEnd,
	PlayerPosition,
	PointAdded
}

public struct Message
{
	public MessageType Type;
	public int IntValue;
	public float FloatValue;
	public Vector3 Vector3Value;
	public GameObject GameObjectValue;
}