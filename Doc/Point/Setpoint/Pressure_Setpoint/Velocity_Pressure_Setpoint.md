[Point](../../Point.md) > [Setpoint](../Setpoint.md) > [Pressure_Setpoint](Pressure_Setpoint.md) > [Velocity_Pressure_Setpoint](.)
# Velocity_Pressure_Setpoint
**DTMI:** dtmi:org:brickschema:schema:Brick:Velocity_Pressure_Setpoint;1
## Display name
- **en:** Velocity Pressure Setpoint
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