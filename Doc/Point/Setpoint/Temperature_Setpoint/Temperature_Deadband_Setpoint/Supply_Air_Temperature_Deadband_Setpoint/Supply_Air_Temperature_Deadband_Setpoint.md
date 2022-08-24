[Point](../../../../Point.md) > [Setpoint](../../../Setpoint.md) > [Temperature_Setpoint](../../Temperature_Setpoint.md) > [Temperature_Deadband_Setpoint](../Temperature_Deadband_Setpoint.md) > [Supply_Air_Temperature_Deadband_Setpoint](.)
# Supply_Air_Temperature_Deadband_Setpoint

**Display name:** Supply Air Temperature Deadband Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Supply_Air_Temperature_Deadband_Setpoint;1

---


## Child interfaces
* [Cooling_Supply_Air_Temperature_Deadband_Setpoint](Cooling_Supply_Air_Temperature_Deadband_Setpoint.md)
* [Heating_Supply_Air_Temperature_Deadband_Setpoint](Heating_Supply_Air_Temperature_Deadband_Setpoint.md)

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
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
