[Point](../../Point.md) > [Setpoint](../Setpoint.md) > [Deadband_Setpoint](#)
# Deadband_Setpoint

**Display name:** Deadband Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Deadband_Setpoint;1

---


## Child interfaces
* [Humidity_Deadband_Setpoint](Humidity_Deadband_Setpoint.md)
* [Temperature_Deadband_Setpoint](../Temperature_Setpoint/Temperature_Deadband_Setpoint/Temperature_Deadband_Setpoint.md)
* [Air_Flow_Deadband_Setpoint](../Flow_Setpoint/Air_Flow_Setpoint/Air_Flow_Deadband_Setpoint/Air_Flow_Deadband_Setpoint.md)
* [Static_Pressure_Deadband_Setpoint](../Pressure_Setpoint/Static_Pressure_Setpoint/Static_Pressure_Deadband_Setpoint/Static_Pressure_Deadband_Setpoint.md)

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
