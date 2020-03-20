# WebHook
Simple webhook that reacts to http push messages

## How to use it: 

The message should look like this
```
{
	"meta": {
		"notificationType": "update"
	},
	"data": {
		"correlationId" : "bba886a0-bfa8-43f3-9d3f-3bcecb2f17bd",
		"status" : "InProgress",
		"timeStamp" : "2020-02-15T13:45:30"
	}
}
```

Send it via POST to this endpoint: http://localhost:{portnr}/webhook/notification
