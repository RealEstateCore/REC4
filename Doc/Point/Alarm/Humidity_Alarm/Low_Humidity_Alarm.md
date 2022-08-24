[Point](../../Point.md) > [Alarm](../Alarm.md) > [Humidity_Alarm](Humidity_Alarm.md) > [Low_Humidity_Alarm](.)
# Low_Humidity_Alarm
**DTMI:** dtmi:org:brickschema:schema:Brick:Low_Humidity_Alarm;1
## Display name
- **en:** Low Humidity Alarm
## Description
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|array (string)|False|
### Inherited Properties
* **dtmi:org:brickschema:schema:Brick:Point;1:** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name
## Target Of
### Inherited
* Asset.hasPoint
* EquipmentCollection.hasPoint
* ActuationEvent.targetPoint
* ExceptionEvent.sourcePoint
* ObservationEvent.sourcePoint
* ServiceObject.producedBy
* Architecture.hasPoint
