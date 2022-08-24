[Point](../../../Point.md) > [Setpoint](../../Setpoint.md) > [Flow_Setpoint](../Flow_Setpoint.md) > [Air_Flow_Setpoint](#)
# Air_Flow_Setpoint

**Display name:** Air Flow Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Air_Flow_Setpoint;1

---


## Child interfaces
* [Outside_Air_Flow_Setpoint](Outside_Air_Flow_Setpoint.md)
* [Air_Flow_Deadband_Setpoint](Air_Flow_Deadband_Setpoint/Air_Flow_Deadband_Setpoint.md)
* [Air_Flow_Demand_Setpoint](Air_Flow_Demand_Setpoint/Air_Flow_Demand_Setpoint.md)
* [Discharge_Air_Flow_Setpoint](Discharge_Air_Flow_Setpoint/Discharge_Air_Flow_Setpoint.md)
* [Exhaust_Air_Flow_Setpoint](Exhaust_Air_Flow_Setpoint/Exhaust_Air_Flow_Setpoint.md)
* [Supply_Air_Flow_Setpoint](Supply_Air_Flow_Setpoint/Supply_Air_Flow_Setpoint.md)

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
