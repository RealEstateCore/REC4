[Point](../../Point.md) > [Setpoint](../Setpoint.md) > [Pressure_Setpoint](.)
# Pressure_Setpoint

**Display name:** Pressure Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Pressure_Setpoint;1

---


## Child interfaces
* [Velocity_Pressure_Setpoint](Velocity_Pressure_Setpoint.md)
* [Static_Pressure_Setpoint](Static_Pressure_Setpoint/Static_Pressure_Setpoint.md)

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
