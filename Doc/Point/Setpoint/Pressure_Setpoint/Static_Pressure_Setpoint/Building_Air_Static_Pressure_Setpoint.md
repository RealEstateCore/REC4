[Point](../../../Point.md) > [Setpoint](../../Setpoint.md) > [Pressure_Setpoint](../Pressure_Setpoint.md) > [Static_Pressure_Setpoint](Static_Pressure_Setpoint.md) > [Building_Air_Static_Pressure_Setpoint](.)
# Building_Air_Static_Pressure_Setpoint
**DTMI:** dtmi:org:brickschema:schema:Brick:Building_Air_Static_Pressure_Setpoint;1
## Display name
- **en:** Building Air Static Pressure Setpoint
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