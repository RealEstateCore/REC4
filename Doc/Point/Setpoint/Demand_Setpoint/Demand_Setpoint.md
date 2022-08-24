[Point](../../Point.md) > [Setpoint](../Setpoint.md) > [Demand_Setpoint](.)
# Demand_Setpoint

**Display name:** Demand Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Demand_Setpoint;1

---


## Child interfaces
* [Cooling_Demand_Setpoint](Cooling_Demand_Setpoint.md)
* [Heating_Demand_Setpoint](Heating_Demand_Setpoint.md)
* [Preheat_Demand_Setpoint](Preheat_Demand_Setpoint.md)
* [Air_Flow_Demand_Setpoint](../Flow_Setpoint/Air_Flow_Setpoint/Air_Flow_Demand_Setpoint/Air_Flow_Demand_Setpoint.md)

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
