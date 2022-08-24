[Point](../../../Point.md) > [Setpoint](../../Setpoint.md) > [Differential_Setpoint](../Differential_Setpoint.md) > [Temperature_Differential_Reset_Setpoint](Temperature_Differential_Reset_Setpoint.md) > [Supply_Air_Temperature_Reset_Differential_Setpoint](.)
# Supply_Air_Temperature_Reset_Differential_Setpoint
**DTMI:** dtmi:org:brickschema:schema:Brick:Supply_Air_Temperature_Reset_Differential_Setpoint;1
## Display name
- **en:** Supply Air Temperature Reset Differential Setpoint
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