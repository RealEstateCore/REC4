[Point](../../Point.md) > [Alarm](../Alarm.md) > [Cycle_Alarm](Cycle_Alarm.md) > [Short_Cycle_Alarm](.)
# Short_Cycle_Alarm
**DTMI:** dtmi:org:brickschema:schema:Brick:Short_Cycle_Alarm;1
## Display name
- **en:** Short Cycle Alarm
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
