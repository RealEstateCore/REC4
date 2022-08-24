[Point](../../../Point.md) > [Setpoint](../../Setpoint.md) > [Differential_Setpoint](../Differential_Setpoint.md) > [Differential_Pressure_Deadband_Setpoint](.)
# Differential_Pressure_Deadband_Setpoint

**Display name:** Differential Pressure Deadband Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Differential_Pressure_Deadband_Setpoint;1

---


## Child interfaces
* [Chilled_Water_Differential_Pressure_Deadband_Setpoint](Chilled_Water_Differential_Pressure_Deadband_Setpoint.md)
* [Entering_Water_Differential_Pressure_Deadband_Setpoint](Entering_Water_Differential_Pressure_Deadband_Setpoint.md)
* [Hot_Water_Differential_Pressure_Deadband_Setpoint](Hot_Water_Differential_Pressure_Deadband_Setpoint.md)
* [Leaving_Water_Differential_Pressure_Deadband_Setpoint](Leaving_Water_Differential_Pressure_Deadband_Setpoint.md)

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
