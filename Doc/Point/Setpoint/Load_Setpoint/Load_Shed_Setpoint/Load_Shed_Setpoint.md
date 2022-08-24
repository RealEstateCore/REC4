[Point](../../../Point.md) > [Setpoint](../../Setpoint.md) > [Load_Setpoint](../Load_Setpoint.md) > [Load_Shed_Setpoint](#)
# Load_Shed_Setpoint

**Display name:** Load Shed Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Load_Shed_Setpoint;1

---


## Child interfaces
* [Entering_Medium_Temperature_Hot_Water_Temperature_Load_Shed_Setpoint](Entering_Medium_Temperature_Hot_Water_Temperature_Load_Shed_Setpoint.md)
* [Leaving_Medium_Temperature_Hot_Water_Temperature_Load_Shed_Setpoint](Leaving_Medium_Temperature_Hot_Water_Temperature_Load_Shed_Setpoint.md)
* [Load_Shed_Differential_Pressure_Setpoint](Load_Shed_Differential_Pressure_Setpoint/Load_Shed_Differential_Pressure_Setpoint.md)

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
