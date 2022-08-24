[Point](../../Point.md) > [Sensor](../Sensor.md) > [Demand_Sensor](#)
# Demand_Sensor

**Display name:** Demand Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Demand_Sensor;1

---


## Child interfaces
* [Cooling_Demand_Sensor](Cooling_Demand_Sensor/Cooling_Demand_Sensor.md)
* [Heating_Demand_Sensor](Heating_Demand_Sensor/Heating_Demand_Sensor.md)
* [Peak_Power_Demand_Sensor](../Power_Sensor/Electric_Power_Sensor/Peak_Power_Demand_Sensor.md)

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
