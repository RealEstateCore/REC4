[Point](../../../Point.md) > [Alarm](../../Alarm.md) > [Water_Alarm](../Water_Alarm.md) > [Water_Temperature_Alarm](Water_Temperature_Alarm.md) > [Entering_Water_Temperature_Alarm](.)
# Entering_Water_Temperature_Alarm
**DTMI:** dtmi:org:brickschema:schema:Brick:Entering_Water_Temperature_Alarm;1
## Display name
- **en:** Entering Water Temperature Alarm
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