[Point](../../../Point.md) > [Setpoint](../../Setpoint.md) > [Differential_Setpoint](../Differential_Setpoint.md) > [Differential_Pressure_Setpoint](#)
# Differential_Pressure_Setpoint

**Display name:** Differential Pressure Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Differential_Pressure_Setpoint;1

---


## Child interfaces
* [Air_Differential_Pressure_Setpoint](Air_Differential_Pressure_Setpoint/Air_Differential_Pressure_Setpoint.md)
* [Load_Shed_Differential_Pressure_Setpoint](../../Load_Setpoint/Load_Shed_Setpoint/Load_Shed_Differential_Pressure_Setpoint/Load_Shed_Differential_Pressure_Setpoint.md)
* [Water_Differential_Pressure_Setpoint](Water_Differential_Pressure_Setpoint/Water_Differential_Pressure_Setpoint.md)

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
