[Point](../../Point.md) > [Setpoint](../Setpoint.md) > [Time_Setpoint](Time_Setpoint.md) > [Deceleration_Time_Setpoint](.)
# Deceleration_Time_Setpoint
**DTMI:** dtmi:org:brickschema:schema:Brick:Deceleration_Time_Setpoint;1
## Display name
- **en:** Deceleration Time Setpoint
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
