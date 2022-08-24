[Point](../../../../Point.md) > [Setpoint](../../../Setpoint.md) > [Temperature_Setpoint](../../Temperature_Setpoint.md) > [Temperature_Deadband_Setpoint](../Temperature_Deadband_Setpoint.md) > [Supply_Air_Temperature_Deadband_Setpoint](Supply_Air_Temperature_Deadband_Setpoint.md) > [Cooling_Supply_Air_Temperature_Deadband_Setpoint](.)
# Cooling_Supply_Air_Temperature_Deadband_Setpoint
**DTMI:** dtmi:org:brickschema:schema:Brick:Cooling_Supply_Air_Temperature_Deadband_Setpoint;1
## Display name
- **en:** Cooling Supply Air Temperature Deadband Setpoint
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
