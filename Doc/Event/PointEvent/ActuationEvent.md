[Event](../Event.md) > [PointEvent](PointEvent.md) > [ActuationEvent](.)
# ActuationEvent

**Display name:** Actuation event<br />
**DTMI:** dtmi:org:w3id:rec:ActuationEvent;1

---
## Relationships
|Name|Display name|Description|Multiplicity|Target|Properties|Writable|
|-|-|-|-|-|-|-|
|targetPoint|**en**: target point|**en**: The brick:Point(s) (e.g., brick:Commands, brick:Setpoints, or brick:Parameters) that the actuation will target/execute.|0-Infinity|dtmi:org:brickschema:schema:Brick:Point;1||True|
## Properties
### Inherited Properties
* **dtmi:org:w3id:rec:PointEvent;1:** payload
* **dtmi:org:w3id:rec:Event;1:** customTags, end, externalIds, name, start, timestamp
## Target Of
