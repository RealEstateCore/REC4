[Point](../../Point.md) > [Alarm](../Alarm.md) > [Pressure_Alarm](Pressure_Alarm.md) > [High_Head_Pressure_Alarm](.)
# High_Head_Pressure_Alarm
**DTMI:** dtmi:org:brickschema:schema:Brick:High_Head_Pressure_Alarm;1
## Display name
- **en:** High Head Pressure Alarm
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
