[Point](../../../../Point.md) > [Setpoint](../../../Setpoint.md) > [Temperature_Setpoint](../../Temperature_Setpoint.md) > [Water_Temperature_Setpoint](../Water_Temperature_Setpoint.md) > [Leaving_Water_Temperature_Setpoint](.)
# Leaving_Water_Temperature_Setpoint

**Display name:** Leaving Water Temperature Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Leaving_Water_Temperature_Setpoint;1

---


## Child interfaces
* [Leaving_Chilled_Water_Temperature_Setpoint](Leaving_Chilled_Water_Temperature_Setpoint.md)
* [Leaving_Hot_Water_Temperature_Setpoint](Leaving_Hot_Water_Temperature_Setpoint.md)
* [Entering_Condenser_Water_Temperature_Setpoint](Entering_Condenser_Water_Temperature_Setpoint.md)
* [Leaving_Condenser_Water_Temperature_Setpoint](Leaving_Condenser_Water_Temperature_Setpoint.md)
* [Leaving_Water_Temperature_Deadband_Setpoint](Leaving_Water_Temperature_Deadband_Setpoint.md)
* [Leaving_Domestic_Hot_Water_Temperature_Setpoint](../Hot_Water_Temperature_Setpoint/Domestic_Hot_Water_Temperature_Setpoint/Leaving_Domestic_Hot_Water_Temperature_Setpoint.md)

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
