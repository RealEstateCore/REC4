[Point](../../../../Point.md) > [Setpoint](../../../Setpoint.md) > [Flow_Setpoint](../../Flow_Setpoint.md) > [Water_Flow_Setpoint](../Water_Flow_Setpoint.md) > [Chilled_Water_Flow_Setpoint](#)
# Chilled_Water_Flow_Setpoint

**Display name:** Chilled Water Flow Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Chilled_Water_Flow_Setpoint;1

---


## Child interfaces
* [Entering_Chilled_Water_Flow_Setpoint](../Entering_Water_Flow_Setpoint/Entering_Chilled_Water_Flow_Setpoint.md)
* [Leaving_Chilled_Water_Flow_Setpoint](../Leaving_Water_Flow_Setpoint/Leaving_Chilled_Water_Flow_Setpoint.md)

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
