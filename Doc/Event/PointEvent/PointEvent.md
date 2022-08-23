# PointEvent
**DTMI:** dtmi:org:w3id:rec:PointEvent;1
## Display name
- **en:** Point event
## Description
- **en:** An event emanating from or targeting a Point; e.g., an individual Observation from a Sensor point, or an Actuation sent to a Command point. In other terms, the Points indicate the capability of some Space or Equipment to emit or accept data, while this class represents those actual data messages. Note that in most non-trivially sized systems, these events are not stored in the knowledge graph itself, but are rather forwarded to some C&C system or time series database.
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|payload|**en**: payload|**en**: The payload message of this point event (e.g., a sensor reading, a command message, an exception message, etc.)|TBD|True|
### Inherited Properties
* **dtmi:org:w3id:rec:Event;1:** customTags, end, externalIds, name, start, timestamp
## Target Of
